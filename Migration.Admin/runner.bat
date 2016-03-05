..\packages\FluentMigrator.1.6.0\tools\Migrate.exe ^
--t migrate:up ^
--db SqlServer2008 ^
--connectionStringConfigPath App.config ^
--connectionString HsbDefaultConnection ^
--timeout=300 ^
-a bin\Debug\Migration.Admin.dll
