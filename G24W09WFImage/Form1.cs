namespace G24W09WFImage {
    public partial class Form1 : Form {
        private int ImageIndex = 0;
        private Image[] Images;

        public Form1() {
            InitializeComponent();

            Images = new Image[] {
                Properties.Resources.건너자쿠워리어sd,
                Properties.Resources.블레이즈자쿠팬텀sd,
                Properties.Resources.주다
            };
        }

        private void OnChange(object sender, EventArgs e) {
            ImageIndex = ++ImageIndex % Images.Length;

            pictureBox1.Image = Images[ImageIndex];
        }
    }
}
 