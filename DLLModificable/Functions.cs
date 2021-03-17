using System;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using Range = Microsoft.Office.Interop.Excel.Range;
//Declaro a que referencia pertenece Range

namespace DLLModificable
{
    public class Functions
    {
        public bool TextToColumn(string path)
        {
            _Workbook dataB;
            _Worksheet dataS;
            Range oResizeRange;
            Application oXL = new Application();

            try
            {
                
                dataB = oXL.Workbooks.Open(path, 0,
                    false, 5, Missing.Value, Missing.Value, false, Missing.Value, Missing.Value,
                    false, false, Missing.Value, false, false, false);
                dataB.Application.DisplayAlerts = false;
                //Si queremos que la Hoja de Excel no se visualice, oXl.Visible = false;
                oXL.Visible = true;
                dataS = (_Worksheet)dataB.ActiveSheet;
    
                //Le hago text to Column siempre a la Columna A. Porque ahi se encuentran los datos.
                //Se puede llegar a modificar esto en caso de ser requerido, pasando como parametro las Celdas.
                dataS.get_Range("A1", ("A" +
                dataS.UsedRange.Rows.Count)).TextToColumns(Type.Missing,
                XlTextParsingType.xlDelimited,
                XlTextQualifier.xlTextQualifierNone, true,
                Type.Missing, Type.Missing, false, true, Type.Missing,
                " ", Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                //Si retorno true, significa que no hay errores
                return true;
            }
            catch (Exception)
            {
                //Si retorno false, es porque algo fallo
                return false;
            }
        }
    }
}
