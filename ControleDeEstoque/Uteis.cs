﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    internal class Uteis
    {
        public static void MensagemErro(string msg)
        {
            MessageBox.Show(msg,
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);           
        }
        public static void MensagemAviso(string msg)
        {
            MessageBox.Show(msg,
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public static void MensagemInfo(string msg)
        {
            MessageBox.Show(msg,
                "Informação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static DialogResult MensagemConfirmacao(string msg)
        {
            return MessageBox.Show(msg,
                "Confirmação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
        }

    }
}
