using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSOLI
{
    internal class _2004PrinterModel
    {
        internal class PrinterModel2004 : Scanner, Imprimir, Cancelar
        {
            void Cancelar.Cancel()
            {
                throw new NotImplementedException();
            }

            void Imprimir.Photocopy()
            {
                throw new NotImplementedException();
            }

            void Imprimir.Print()
            {
                throw new NotImplementedException();
            }

            void Scanner.Scan()
            {
                throw new NotImplementedException();
            }
        }
    }
}

