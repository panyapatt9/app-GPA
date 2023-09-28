namespace โปรแกรมคำนวณ_GPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int noykit1;
            int noykit2;
            int noykit3;
            int noykit4;
            int noykit5;
            int noykit6;
            int noykit7;
            int noykit8;
            int noykit9;
            int noykit10;
            int noykit11;
            int noykit12;
            int noykit13;
            int noykit14;
            int Grade1;
            int Grade2;
            int Grade3;
            int Grade4;
            int Grade5;
            int Grade6;
            int Grade7;
            int Grade8;
            int Grade9;
            int Grade10;
            int Grade11;
            int Grade12;
            int Grade13;
            int Grade14;
            int GPA;
            int allnoykit;
            int sum;
            //หน่วยกิต
            noykit1 = Convert.ToInt32(หน่วยกิต1.SelectedItem);
            noykit2 = Convert.ToInt32(หน่วยกิต2.SelectedItem);
            noykit3 = Convert.ToInt32(หน่วยกิต3.SelectedItem);
            noykit4 = Convert.ToInt32(หน่วยกิต4.SelectedItem);
            noykit5 = Convert.ToInt32(หน่วยกิต5.SelectedItem);
            noykit6 = Convert.ToInt32(หน่วยกิต6.SelectedItem);
            noykit7 = Convert.ToInt32(หน่วยกิต7.SelectedItem);
            noykit8 = Convert.ToInt32(หน่วยกิต8.SelectedItem);
            noykit9 = Convert.ToInt32(หน่วยกิต9.SelectedItem);
            noykit10 = Convert.ToInt32(หน่วยกิต10.SelectedItem);
            noykit11 = Convert.ToInt32(หน่วยกิต11.SelectedItem);
            noykit12 = Convert.ToInt32(หน่วยกิต12.SelectedItem);
            noykit13 = Convert.ToInt32(หน่วยกิต13.SelectedItem);
            noykit14 = Convert.ToInt32(หน่วยกิต14.SelectedItem);
            //เกรด
            Grade1 = Convert.ToInt32(เกรด1.SelectedItem);
            Grade2 = Convert.ToInt32(เกรด1.SelectedItem);
            Grade3 = Convert.ToInt32(เกรด1.SelectedItem);
            Grade4 = Convert.ToInt32(เกรด1.SelectedItem);
            Grade5 = Convert.ToInt32(เกรด1.SelectedItem);
            Grade6 = Convert.ToInt32(เกรด1.SelectedItem);
            Grade7 = Convert.ToInt32(เกรด1.SelectedItem);
            Grade8 = Convert.ToInt32(เกรด1.SelectedItem);
            Grade9 = Convert.ToInt32(เกรด1.SelectedItem);
            Grade10 = Convert.ToInt32(เกรด1.SelectedItem);
            Grade11 = Convert.ToInt32(เกรด1.SelectedItem);
            Grade12 = Convert.ToInt32(เกรด1.SelectedItem);
            Grade13 = Convert.ToInt32(เกรด1.SelectedItem);
            Grade14 = Convert.ToInt32(เกรด1.SelectedItem);
            sum = (noykit1 * Grade1) + (noykit2 * Grade2) + (noykit3 * Grade3) + (noykit4 * Grade4) + (noykit5 * Grade5) + (noykit6 * Grade6) + (noykit7 * Grade7) + (noykit8 * Grade8) + (noykit9 * Grade9) + (noykit10 * Grade10) + (noykit11 * Grade11) + (noykit12 * Grade12) + (noykit13 * Grade13) + (noykit14 * Grade14);
            allnoykit = noykit1 + noykit2 + noykit3 + noykit4 + noykit5 + noykit6 + noykit7 + noykit8 + noykit9 + noykit10 + noykit11 + noykit12 + noykit13 + noykit14;
            GPA = sum / allnoykit;
            label1.Text = Convert.ToString(GPA);

        }
    }
}