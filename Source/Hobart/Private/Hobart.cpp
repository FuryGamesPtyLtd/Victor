

#include "Hobart.h"
#include "Modules/ModuleManager.h"

#include "Wakefield/Print.h"

void FHobart::StartupModule()
{
    Print("Starting up Hobart module");
}

void FHobart::ShutdownModule()
{
    Print("Shutting down Hobart module");
}

IMPLEMENT_PRIMARY_GAME_MODULE(FHobart, Hobart, "Victor");
