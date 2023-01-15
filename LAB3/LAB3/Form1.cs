namespace LAB3
{
    public partial class Form1 : Form
    {
        List<Student> _students = new List<Student>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;
            // student object
            //Student student = new Student("dging",2003) ;
            //Student student1 = new Student("Ging",2002);
            //Student student2 = new Student("Omg",2004);

            // add value to object attribute
            //student._name = "Mike most";
            //student1._id = 2003;
            //student2._age = 18;

            // get value from object attribute
            // textBoxName.Text = student._name;

            //  textBoxBY.Text = student1._id.ToString();

            // textBoxAge.Text = student2._age.ToString();

            //textBoxAge.Text = student1.myAge().ToString();



        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Age_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get value from textbox
            String name = this.textBoxName.Text;
            String ID = this.textBoxId.Text;
            String year = this.textBoxAge.Text;
            String High = this.textBoxHh.Text;
            String Grade = this.textBoxGrade.Text;
            String Major = this.textBoxObj.Text;
            //convert string to in
            int iYear = Int32.Parse(year);
            int iHigh = Int32.Parse(High);

            int Num = 1;

            //create obj from Student
            Student newStudent = new Student(Num, name, ID, iYear, iHigh, Grade, Major);
            //Add new student to list
            this._students.Add(newStudent);

            //clear textbox
            this.textBoxName.Text = "";
            this.textBoxAge.Text = "";
            this.textBoxId.Text = "";
            this.textBoxHh.Text = "";
            this.textBoxGrade.Text = "";
            this.textBoxObj.Text = "";

            // add data to DataGridView
            BindingSource source = new BindingSource();
            source.DataSource = this._students;
            this.dataGridView1.DataSource = source;


        


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }
    }

}