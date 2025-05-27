using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.model
{
    public class Helpers
    {
        public void LimparTela(Form tela)
        {
            // Percorre todos os controles principais do formulário (ex: Painéis, TabControl, etc.)
            foreach (Control ctrPai in tela.Controls)
            {
                // Percorre os controles dentro do controle principal (ex: as abas dentro de um TabControl)
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    // Se o controle for uma aba (TabPage)
                    if (ctr1 is TabPage)
                    {
                        // Percorre os controles dentro da aba
                        foreach (Control ctr2 in ctr1.Controls)
                        {
                            // Se o controle for um TextBox, apaga o texto
                            if (ctr2 is TextBox)
                            {
                                (ctr2 as TextBox).Text = string.Empty;
                            }
                            // Se o controle for um MaskedTextBox, apaga o texto
                            if (ctr2 is MaskedTextBox)
                            {
                                (ctr2 as MaskedTextBox).Text = string.Empty;
                            }
                        }
                    }
                }
            }
        }
    }
}
