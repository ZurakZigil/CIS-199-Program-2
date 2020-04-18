/*
Grading ID: W9957
Program#: 2
Due Date: 3/08/2018 11:59.00
Course Section: 199-01

Description:
A program to determine when a student attending UofL can register for classes. 

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttEnter_Click(object sender, EventArgs e)
        {
            string lastName; //holds the user's last name
            const byte i = 0; //constant for 0 when finding the first letter of the user's name

            //dates and time for graduate students
            const string GRD_DATE = "MARCH 27";
            const string GRD_AZ = "10:30 AM";

            //Hours requirements of classes
            const int intSenior = 90;       //senior
            const int intJunior = 60;       //junior
            const int intSophomore = 30;    //sophomore

            //Dates for seperate classes (1 & 2 to designate the first and second days chronologically)
            const string SNR_DATE = "MARCH 28";     //senior
            const string JNR_DATE = "MARCH 29";     //junior
            const string SOP_DATE1 = "MARCH 30";    //sophomore day 1
            const string SOP_DATE2 = "APRIL 2";     //sophomore day 2
            const string FRS_DATE1 = "APRIL 3";     //freshman day 1
            const string FRS_DATE2 = "APRIL 4";     //freshman day 1

            //constants for times
            const string TIME_1 = "8:30 AM";
            const string TIME_2 = "10:00 AM";
            const string TIME_3 = "11:30 AM";
            const string TIME_4 = "2:00 PM";
            const string TIME_5 = "4:00 PM";

            //used to see whether the user is a graduate, avoids all other logic
            if (cBoxGraduate.Checked)
            {
                displayRegDate.Text = GRD_DATE;
                displayRegTime.Text = GRD_AZ;
                displayYear.Text = "Graduate";
            }
            else
            {
                if ((!double.TryParse(tBoxHours.Text, out double hours)) || hours < 0) //checks that the value entered is a non-negative double
                {
                    MessageBox.Show("Please Enter Valid Number");
                }
                else if (string.IsNullOrWhiteSpace(tBoxLastName.Text) || !char.IsLetter(tBoxLastName.Text[i])) //checks whether a value was typed and whether it was a letter 
                {
                    MessageBox.Show("Please Enter Valid Name");
                }
                else
                {
                    lastName = tBoxLastName.Text;               //declares the users last name from the text box
                    char firstInitial = lastName.ToUpper()[i];  //determines the first letter of their last name

                    //tests for junior and senior
                    if (hours >= intJunior)
                    {
                        if (hours >= intSenior) // testing whether they are a senior
                        {
                            displayYear.Text = $"Senior: {firstInitial}";
                            displayRegDate.Text = SNR_DATE; //displays senior date
                        }
                        else //or ELSE they are a junior
                        {
                            displayYear.Text = $"Junior: {firstInitial}";
                            displayRegDate.Text = JNR_DATE;  //displays junior date
                        }

                        //determines the time based on char
                        if (firstInitial <= 'D') { displayRegTime.Text = TIME_1; }
                        else if (firstInitial <= 'I') { displayRegTime.Text = TIME_2; }
                        else if (firstInitial <= 'O') { displayRegTime.Text = TIME_3; }
                        else if (firstInitial <= 'S') { displayRegTime.Text = TIME_4; }
                        else if (firstInitial <= 'Z') { displayRegTime.Text = TIME_5; }
                    }
                    //tests for freshman and sophomores
                    else
                    {
                        if (hours >= intSophomore) //testing whether they are a sophomore 
                        {
                            displayYear.Text = $"Sophomore: {firstInitial}";
                            //tests for the seperating leter of L for the days
                            if (firstInitial <= 'L') { displayRegDate.Text = SOP_DATE1; } 
                            else { displayRegDate.Text = SOP_DATE2; }
                        }
                        else //or ELSE they are a freshman
                        {
                            displayYear.Text = $"Freshman: {firstInitial}";
                            //tests for the seperating leter of L for the days
                            if (firstInitial <= 'L') { displayRegDate.Text = FRS_DATE1; }
                            else { displayRegDate.Text = FRS_DATE2; }
                        }

                        //determines the time based on char. Holds other tests because of the ranges of repeating times but for different letter ranges
                        if (firstInitial <= 'B' || (firstInitial >= 'M' && firstInitial <='O')) { displayRegTime.Text = TIME_1; }
                        else if (firstInitial <= 'D' || (firstInitial >= 'P' && firstInitial <= 'Q')) { displayRegTime.Text = TIME_2; }
                        else if (firstInitial <= 'F' || (firstInitial >= 'R' && firstInitial <= 'S')) { displayRegTime.Text = TIME_3; }
                        else if (firstInitial <= 'I' || (firstInitial >= 'T' && firstInitial <= 'V')) { displayRegTime.Text = TIME_4; }
                        else if (firstInitial <= 'L' || firstInitial >= 'W' ) { displayRegTime.Text = TIME_5; }
                    }
                }
            }
        }
    }
}
