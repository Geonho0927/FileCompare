# (C# 코딩) 파일 비교툴

## 개요
- C# 프로그래밍 학습
- 1줄 소개:
  - 두 폴더 간의 파일 정보를 비교하고 상태별 색상 구분을 통해 효율적인 동기화를 돕는 파일 관리 도구
- 사용한 플랫폼:
  - C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
  - Label, TextBox, Button, ListView, Panal, SplitContainer
- 사용한 기술과 구현한 기능:
  - FolderBrowserDialog를 활용한 표준 폴더 선택 인터페이스 구현
  - Directory 및 FileInfo 클래스를 이용한 실시간 파일 시스템 정보 추출
  - Try-Catch-Finally 구문을 적용한 입출력 예외 처리 및 프로그램 안정성 확보
  - ListView의 BeginUpdate/EndUpdate를 통한 리스트 갱신 성능 최적화
  - 컬럼 자동 너비 조정 기능을 통한 데이터 출력 가독성 개선

## 실행 화면 (과제1)
- 과제 1 코드의 실행 스크린샷

![과제1 실행 화면](img/screen1.png)

- 과제 내용
	- 사용자로부터 경로를 입력받거나 폴더 선택창을 통해 폴더를 지정합니다.
	- 지정된 폴더 내의 파일 목록을 읽어와 리스트뷰에 상세 정보를 출력합니다.

- 구현 내용과 기능 설명
	- using 구문과 FolderBrowserDialog를 사용하여 메모리 효율성을 높이고 안전하게 폴더 경로를 획득하도록 구현하였습니다.
	- Directory.EnumerateFiles를 사용하여 파일 목록을 가져오고, LINQ를 활용해 파일명 기준으로 오름차순 정렬하여 출력의 일관성을 유지하였습니다.
	- ListViewItem과 SubItems를 활용하여 파일명, 파일 크기, 최종 수정 시간을 상세하게 표시하였습니다.
	- DirectoryNotFoundException 및 IOException 처리를 통해 잘못된 경로 접근이나 파일 사용 중 오류 발생 시 프로그램이 강제 종료되지 않도록 설계하였습니다.