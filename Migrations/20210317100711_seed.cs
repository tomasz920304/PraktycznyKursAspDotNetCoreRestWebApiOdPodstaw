using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            for (int i = 0; i < 10000; i++)
            {
                migrationBuilder.Sql($"insert into Restaurants (Name, HasDelivery) values ('Name{i}', 'true')");
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
