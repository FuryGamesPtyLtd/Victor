

#pragma once

#include "CoreMinimal.h"
#include "Modules/ModuleInterface.h"

class FHobart : public IModuleInterface
{
public:
    static inline FHobart& Get()
    {
        return FModuleManager::LoadModuleChecked<FHobart>("Hobart");
    }

    static inline bool IsAvailable()
    {
        return FModuleManager::Get().IsModuleLoaded("Hobart");
    }

    virtual void StartupModule() override;
    virtual void ShutdownModule() override;
};
