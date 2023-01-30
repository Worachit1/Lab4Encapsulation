namespace Lab_04_OOP
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textboxname.Text;
            string birthyear = this.textboxbirthyear.Text;
            string grade = this.tbgrade.Text;

            int bYear = Int32.Parse(birthyear);
            double gpa = Double.Parse(grade);
            // create object form Person class
            Person person = new Person(name, bYear, gpa);
            this.classroom.addPerson2Class(person);
            //display person
            this.tbtotalname.Text = this.classroom.showAllPersoninClass();
            //display total age of class
            this.textboxtotal.Text = this.classroom.showsumageinClass().ToString();
            // display avg Grade 
            this.tbavggrade.Text = this.classroom.avggradeinClass().ToString("#.##"); 

            // display min max GPA
            this.tbmax.Text = this.classroom.Maxgrade().ToString();
            this.tbmin.Text = this.classroom.Mingrade().ToString();

            // display name min max
            this.tbnamemax.Text = this.classroom.shownamemaxGPA().ToString();
            this.tbnamemin.Text = this.classroom.shownameminGPA().ToString();
            
            // clear 
            this.textboxname.Text = "";
            this.textboxbirthyear.Text = "";
            this.tbgrade.Text = "";

        }

    }
}