﻿using AdapterPatern.Adapters;
using AdapterPatern.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterPatern.Forms
{
    public partial class StudentForm : Form
    {
        private SaveAdapter saveAdapter;

        public StudentForm(SaveAdapter saveAdapter)
        {
            InitializeComponent();
            this.saveAdapter = saveAdapter;
        }

        private void tAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.name = tName.Text;
            s.code = tCode.Text;
            s.age = Convert.ToInt32(tAge.Text);
            if (rMale.Checked)
            {
                s.gender = rMale.Text;
            }
            else if(rFemale.Checked)
            {
                s.gender = rFemale.Text;
            }
            s.address = tAddress.Text;
            saveAdapter.setElement(s);
            System.Windows.Forms.MessageBox.Show("The new student was saved succesfully!");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
