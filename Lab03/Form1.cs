namespace Lab03
{
    public partial class Form1 : Form
    {
        List<Student> _students = new List<Student>();
        // max min grade 
        double Maxgrade = 0;
        double Mingrade = int.MaxValue;
        int number_Student = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //get value form texbox
            String name = this.textBoxName.Text;
            String id = this.textBoxId.Text;
            String year = this.textBoxBirthyear.Text;
            String hight = this.textBoxHeight.Text;
            String grade = this.textBoxGrade.Text;
            String major = this.textBoxMajor.Text;

            //convert string to in
            int iYear = Int32.Parse(year);
            int iHight = Int32.Parse(hight);
            double iGrade = Double.Parse(grade);

            //create obj form student
            Student newStudent = new Student(name, id, iYear, iHight, iGrade, major);
            //add new student to list
            this._students.Add(newStudent);

            //cal max min
            if (iGrade > Maxgrade)
            {
                Maxgrade = iGrade;
            }
            if (iGrade < Mingrade)
            {
                Mingrade = iGrade;
            }

            //cal num Student
            number_Student = number_Student + 1;

            //clear textbox
            this.textBoxName.Text = "";
            this.textBoxId.Text = "";
            this.textBoxBirthyear.Text = "";
            this.textBoxHeight.Text = "";
            this.textBoxGrade.Text = "";
            this.textBoxMajor.Text = "";
            this.textBoxMax.Text = "";
            this.textBoxMin.Text = "";
            this.textBoxNum.Text = "";

            //show max min grade
            this.textBoxMax.Text = this.textBoxMax.Text + Maxgrade;
            this.textBoxMin.Text = this.textBoxMin.Text + Mingrade;

            //show num Stdent
            this.textBoxNum.Text = this.textBoxNum.Text + number_Student;

            //add data to DataGridView
            BindingSource source = new BindingSource();
            source.DataSource = this._students;
            this.dataGridView1.DataSource = source;
        }


    }
}