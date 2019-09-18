using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace TestClobOrm
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("DBTESTCLOB")]
    public partial class Dbtestclob
    {
           public Dbtestclob(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DATA {get;set;}

    }
}
