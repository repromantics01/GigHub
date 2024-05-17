using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigHubLibrary.Models
{
    public enum UserType
    {
        student,
        faculty
    }
    public enum GigType
    {
        on_site,
        remote,
        flexible
    }
    public enum GigStatus
    {
        open,
        closed,
    }
    public enum DatabaseType
    {
        Sql,
        TextFile
    }

}
