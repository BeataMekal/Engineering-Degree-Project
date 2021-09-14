using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotRaspberryPi.bazaDanych
{
    class Delete
    {
        DBConnect glownyDelete = new DBConnect();
        public void DeletePomiar(int nrId)
        {
            string queryD = "DELETE FROM Pomiary WHERE idPomiary='" + nrId + "'";
            string queryR = "SELECT * FROM Pomiary";
            glownyDelete.Delete(queryD,queryR);
 
        }
        public void DeleteSekwencje(int nrId)
        {
            string queryD = "DELETE FROM SekwencjeRuchow WHERE idSekwencjeRuchow='" + nrId + "'";
            string queryR = "SELECT * FROM SekwencjeRuchow";
            glownyDelete.Delete(queryD,queryR);
        }

    }
}
