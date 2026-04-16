namespace FileCompare
{
    public partial class FileCompare : Form
    {
        public FileCompare()
        {
            InitializeComponent();
        }
        private void PopulateListView(ListView lv, string folderPath, string otherPath)
        {
            if (string.IsNullOrWhiteSpace(folderPath) || !Directory.Exists(folderPath)) return;

            lv.BeginUpdate();
            lv.Items.Clear();

            try
            {
                Dictionary<string, FileInfo> otherFiles = null;

                if (!string.IsNullOrWhiteSpace(otherPath) && Directory.Exists(otherPath))
                {
                    otherFiles = Directory.EnumerateFiles(otherPath)
                                          .Select(p => new FileInfo(p))
                                          .ToDictionary(f => f.Name);
                }

                var dirs = Directory.EnumerateDirectories(folderPath).Select(p => new DirectoryInfo(p)).OrderBy(d => d.Name);
                foreach (var dir in dirs)
                {
                    var item = new ListViewItem(dir.Name);
                    item.SubItems.Add("<DIR>");
                    item.SubItems.Add(dir.LastWriteTime.ToString("g"));
                    lv.Items.Add(item);
                }

                var files = Directory.EnumerateFiles(folderPath).Select(p => new FileInfo(p)).OrderBy(f => f.Name);
                foreach (var file in files)
                {
                    var item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.Length.ToString("N0") + "바이트");
                    item.SubItems.Add(file.LastWriteTime.ToString("g"));

                    if (otherFiles == null)
                    {
                        item.ForeColor = Color.Black;
                    }
                    else if (otherFiles.TryGetValue(file.Name, out FileInfo rf))
                    {
                        if (file.LastWriteTime == rf.LastWriteTime)
                            item.ForeColor = Color.Black;
                        else if (file.LastWriteTime > rf.LastWriteTime)
                            item.ForeColor = Color.Red;
                        else
                            item.ForeColor = Color.Gray;
                    }
                    else
                    {
                        item.ForeColor = Color.Purple;
                    }

                    lv.Items.Add(item);
                }

                for (int i = 0; i < lv.Columns.Count; i++)
                    lv.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
            finally
            {
                lv.EndUpdate();
            }
        }

        private void CopySelectedFiles(ListView sourceLv, string sourcePath, string targetPath)
        {
            // 1. 폴더 선택 여부 확인
            if (string.IsNullOrWhiteSpace(sourcePath) || string.IsNullOrWhiteSpace(targetPath))
            {
                MessageBox.Show("양쪽 폴더가 모두 선택되어야 합니다.", "알림");
                return;
            }

            // 2. 선택된 항목 존재 여부 확인
            if (sourceLv.SelectedItems.Count == 0)
            {
                MessageBox.Show("복사할 파일을 선택해주세요.", "알림");
                return;
            }

            int copyCount = 0; // 실제 복사 성공 횟수를 추적

            foreach (ListViewItem item in sourceLv.SelectedItems)
            {
                string fileName = item.Text;

                // 폴더(<DIR>)는 복사 대상에서 제외
                if (item.SubItems[1].Text == "<DIR>") continue;

                string sourceFile = Path.Combine(sourcePath, fileName);
                string targetFile = Path.Combine(targetPath, fileName);

                // 3. 대상 폴더에 동일 파일이 존재할 경우 날짜 비교 및 확인
                if (File.Exists(targetFile))
                {
                    DateTime sourceTime = File.GetLastWriteTime(sourceFile);
                    DateTime targetTime = File.GetLastWriteTime(targetFile);

                    string msg = $"대상 폴더에 동일한 파일이 존재합니다.\n\n" +
                                 $"원본 날짜: {sourceTime:g}\n" +
                                 $"대상 날짜: {targetTime:g}\n\n" +
                                 $"덮어쓰시겠습니까?";

                    // '아니오' 선택 시 해당 파일 복사를 건너뜀
                    if (MessageBox.Show(msg, "복사 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        continue;
                    }
                }

                try
                {
                    // 4. 파일 복사 실행 (덮어쓰기 허용)
                    File.Copy(sourceFile, targetFile, true);
                    copyCount++; // 복사 성공 시에만 카운트 증가
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{fileName} 복사 중 오류 발생: {ex.Message}", "오류");
                }
            }

            // 5. 최종 결과 처리: 실제로 복사된 파일이 1개 이상일 때만 수행
            if (copyCount > 0)
            {
                PopulateListView(lvwLeftDir, txtLeftDir.Text, txtRightDir.Text);
                PopulateListView(lvwRightDir, txtRightDir.Text, txtLeftDir.Text);
                MessageBox.Show($"{copyCount}개의 파일이 성공적으로 복사되었습니다.", "완료");
            }
        }
        private void btnLeftDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "폴더를 선택하세요.";

                if (!string.IsNullOrWhiteSpace(txtLeftDir.Text) && Directory.Exists(txtLeftDir.Text))
                {
                    dlg.SelectedPath = txtLeftDir.Text;
                }
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtLeftDir.Text = dlg.SelectedPath;
                    PopulateListView(lvwLeftDir, txtLeftDir.Text, txtRightDir.Text);
                    PopulateListView(lvwRightDir, txtRightDir.Text, txtLeftDir.Text);
                }
            }
        }

        private void btnRightDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "폴더를 선택하세요.";

                if (!string.IsNullOrWhiteSpace(txtRightDir.Text) && Directory.Exists(txtRightDir.Text))
                {
                    dlg.SelectedPath = txtRightDir.Text;
                }
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtRightDir.Text = dlg.SelectedPath;
                    PopulateListView(lvwLeftDir, txtLeftDir.Text, txtRightDir.Text);
                    PopulateListView(lvwRightDir, txtRightDir.Text, txtLeftDir.Text);
                }
            }
        }

        private void btnCopyFromLeft_Click(object sender, EventArgs e)
        {
            CopySelectedFiles(lvwLeftDir, txtLeftDir.Text, txtRightDir.Text);
        }

        private void btnCopyFromRight_Click(object sender, EventArgs e)
        {
            CopySelectedFiles(lvwRightDir, txtRightDir.Text, txtLeftDir.Text);
        }
    }
}
