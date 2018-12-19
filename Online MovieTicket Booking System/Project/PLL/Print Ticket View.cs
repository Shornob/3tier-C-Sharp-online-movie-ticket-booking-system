using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BLL;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace MovieTicketBookingSystem.PLL
{
    public partial class Print_Ticket : MetroFramework.Forms.MetroForm
    {
        employee aa = new employee();
        movie mm = new movie();
        public Print_Ticket(employee a)
        {
            InitializeComponent();
            aa = a;
        }
  
        public Print_Ticket(employee a, int movieId, int hallId, int slot, DateTime movieDate, string seatNo)
        {
            InitializeComponent();
            aa = a;
            this.movieNameLabel.Text = mm.GetMovieName(movieId);
            this.hallNoLabel.Text = hallId.ToString();
            this.seatLabel.Text = seatNo.ToString();
            this.showDateLabel.Text = movieDate.ToString("dd-mm-yyyy");
            if(slot==1)
            {
                this.showTimeLabel.Text = "11.00-2.00 a.m";
            }
            else if (slot == 2)
            {
                this.showTimeLabel.Text = "2.00-5.00 p.m";
            }
            else if (slot == 3)
            {
                this.showTimeLabel.Text = "5.00-8.00 p.m";
            }
            else { }

            if (seatNo.Contains("S"))
            {
                priceLabel.Text = "300 Taka";
            }
            else if (seatNo.Contains("G"))
            {
                priceLabel.Text = "500 Taka";
            }
            else if (seatNo.Contains("P"))
            {
                priceLabel.Text = "1000 Taka";
            }
            else { priceLabel.Text = "Magna Movie Nai :/ "; }

        }

        private void Print_Ticket_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Employee_Home eh = new Employee_Home(aa);
            this.Hide();
            eh.Show();
        }

        private void Print_Ticket_Load(object sender, EventArgs e)
        {

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Document pdoc = new Document(PageSize.A6, 10f, 10f, 20f, 20f);
            PdfWriter pWriter = PdfWriter.GetInstance(pdoc, new FileStream("D:\\ticket.pdf", FileMode.Create));
            pdoc.Open();

            Paragraph p1 = new Paragraph("Movie Ticket");
            p1.Alignment = Element.ALIGN_CENTER;
            pdoc.Add(p1);

            Paragraph p8 = new Paragraph("                ");
            p8.Alignment = Element.ALIGN_CENTER;
            pdoc.Add(p8);

            Paragraph p2 = new Paragraph("Movie Name : " + movieNameLabel.Text);
            p2.Alignment = Element.ALIGN_LEFT;
            pdoc.Add(p2);

            Paragraph p3 = new Paragraph("Show Date : " + showDateLabel.Text);
            p3.Alignment = Element.ALIGN_LEFT;
            pdoc.Add(p3);

            Paragraph p4 = new Paragraph("Seat No : " + seatLabel.Text);
            p4.Alignment = Element.ALIGN_LEFT;
            pdoc.Add(p4);

            Paragraph p5 = new Paragraph("Hall No : " + hallNoLabel.Text);
            p5.Alignment = Element.ALIGN_LEFT;
            pdoc.Add(p5);

            Paragraph p6 = new Paragraph("Show Time : " + showTimeLabel.Text);
            p6.Alignment = Element.ALIGN_LEFT;
            pdoc.Add(p6);

            Paragraph p10 = new Paragraph("Ticket Price : " + priceLabel.Text );
            p10.Alignment = Element.ALIGN_LEFT;
            pdoc.Add(p10);

            Paragraph p9 = new Paragraph("                ");
            p9.Alignment = Element.ALIGN_CENTER;
            pdoc.Add(p9);

            Paragraph p7 = new Paragraph("Enjoy the Movie. Thank You!");
            p7.Alignment = Element.ALIGN_CENTER;
            pdoc.Add(p7);

            pdoc.Close();

            MessageBox.Show("Ticket Printed");
        }
    }
}
