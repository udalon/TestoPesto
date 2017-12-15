using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestoPesto.classes
{
    class ExportToExcel
    {
        private FormControlsData controlData = new FormControlsData();


        public void exportToExcel(string langPath, string server, string language, string timestamp,FormControlsData cData)
        {
            controlData = cData;
            // Don't save if no data is returned
            if (controlData.dg_games.Rows.Count == 0)
            {
                return;
            }


            StringBuilder sb = new StringBuilder();
            // Column headers
            string columnsHeader = "";
            for (int i = 0; i < controlData.dg_games.Columns.Count; i++)
            {
                columnsHeader += controlData.dg_games.Columns[i].Name + ",";
            }
            sb.Append(columnsHeader + Environment.NewLine);
            // Go through each cell in the datagridview
            foreach (DataGridViewRow dgvRow in controlData.dg_games.Rows)
            {
                // Make sure it's not an empty row.
                if (!dgvRow.IsNewRow)
                {
                    for (int c = 0; c < dgvRow.Cells.Count; c++)
                    {
                        // Append the cells data followed by a comma to delimit.

                        sb.Append(dgvRow.Cells[c].Value + ",");
                    }
                    // Add a new line in the text file.
                    sb.Append(Environment.NewLine);
                }
            }

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(langPath + "\\" + server + "_" + language + "_" + timestamp + "_" + controlData.folderLabel + ".csv"))
            {
                sw.WriteLine(sb.ToString());
            
            }
        }



    }
}
