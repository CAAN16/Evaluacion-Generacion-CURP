using BibliotecaCurp;

namespace FormTestCurp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ctlCurp componenteCurp = new ctlCurp();
            this.Controls.Add(componenteCurp);
        }
    }
}
