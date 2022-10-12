namespace PictureApplication
{
    public partial class Form1 : Form
    {
        String[] imageArray = { "D:\\(SIBA) BS CS\\Fall-2022\\Visual Programming\\Labs\\PictureApplication\\Images\\1.jpg",
            "D:\\(SIBA) BS CS\\Fall-2022\\Visual Programming\\Labs\\PictureApplication\\Images\\2.jpg",
            "D:\\(SIBA) BS CS\\Fall-2022\\Visual Programming\\Labs\\PictureApplication\\Images\\3.jpg",
            "D:\\(SIBA) BS CS\\Fall-2022\\Visual Programming\\Labs\\PictureApplication\\Images\\4.jpg",
            "D:\\(SIBA) BS CS\\Fall-2022\\Visual Programming\\Labs\\PictureApplication\\Images\\5.jpg",
            "D:\\(SIBA) BS CS\\Fall-2022\\Visual Programming\\Labs\\PictureApplication\\Images\\6.jpg"
        };
        int counter = 0;
        
        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.ImageLocation = "D:\\(SIBA) BS CS\\Fall-2022\\Visual Programming\\Labs\\PictureApplication\\Images\\1.jpg";
            this.label1.Text = "Image: " + (counter + 1);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            frmPictureViewer(0);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmPictureViewer(1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void frmPictureViewer(int state) {
            if (counter <= 0)
            {
                counter = 5;
            }
            else if (counter >= 5) {
                counter = 0;
            }

            if (state == 1)
            {
                this.pictureBox1.ImageLocation = imageArray[counter++];
            }
            else
            {
                this.pictureBox1.ImageLocation = imageArray[--counter];
            }
            this.label1.Text = "Image: " + counter;

        }
    }
}