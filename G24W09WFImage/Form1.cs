namespace G24W09WFImage {
    public partial class Form1 : Form {
        private int ImageIndex = 0;
        private Image[] Images;

        public Form1() {
            InitializeComponent();

            Images = new Image[] {
                Properties.Resources.�ǳ����������sd,
                Properties.Resources.��������������sd,
                Properties.Resources.�ִ�
            };
        }

        private void OnChange(object sender, EventArgs e) {
            ImageIndex = ++ImageIndex % Images.Length;

            pictureBox1.Image = Images[ImageIndex];
        }
    }
}
 