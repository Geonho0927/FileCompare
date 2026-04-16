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
    }
}
