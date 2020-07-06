using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Reflection;
using System.Web;
using mvcCodeFirstTest.Migrations;


namespace mvcCodeFirstTest
{
	public static  class clsAd
	{



		public static void RunMigration( )
		{
			var mg = new m1();

			//mg.Up();

			mg.Down();

			var context = new ModelNW3();

			var prop = mg.GetType().GetProperty("Operations", BindingFlags.NonPublic | BindingFlags.Instance);

			if (prop != null)
			{
				IEnumerable<MigrationOperation> operations = prop.GetValue(mg ) as IEnumerable<MigrationOperation>;

				var generator = new SqlServerMigrationSqlGenerator();
				var statements = generator.Generate(operations, "2008");

				try
				{
					foreach (MigrationStatement item in statements)
						context.Database.ExecuteSqlCommand(item.Sql);
				}
				catch (Exception ex)
				{
					//does not exist in table - 4924
					//Column names in each table must be unique - 2705
 					var ss = ex.Message ;
					return;
				}	  
			}


		}





	}
}