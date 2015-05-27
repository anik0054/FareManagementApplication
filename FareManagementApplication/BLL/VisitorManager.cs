using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FareManagementApplication.DAL;
using FareManagementApplication.Model;

namespace FareManagementApplication.BLL
{
    class VisitorManager
    {
        VisitorGateway visitorGateway=new VisitorGateway();
        public int SaveVisitor(Visitor visitor)
        {
            return visitorGateway.SaveVisitor(visitor);
        }
    }
}
