using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsFacade.Office
{
    public class MsExcel :OfficeInterop
    {
        private MsExcel _instance;

        private MsExcel(){}

        public MsExcel GetInstance()
        {
            return _instance ?? (_instance = new MsExcel());
        }
    }
}
