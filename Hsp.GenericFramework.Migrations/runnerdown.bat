..\Binaries\FluentMigrator\FluentMigrator.Tools.1.3.0.0\tools\AnyCPU\40\Migrate.exe ^
--t rollback:toversion ^
--version 20150629112616 ^
--db SqlServer2008 ^
--connectionStringConfigPath App.config ^
--connectionString CarPark_WriteOnly ^
--timeout=300 ^
--a bin\Debug\Migrations.dll
