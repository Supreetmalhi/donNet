using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AssignmentPart4.Models
{
    public class InsuranceDBInitializer : CreateDatabaseIfNotExists<InsuranceContext>
    {
    }
}