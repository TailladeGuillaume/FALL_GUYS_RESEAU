// Copyright Epic Games, Inc. All Rights Reserved.

#include "FALL_GUYS_RESEAUGameMode.h"
#include "FALL_GUYS_RESEAUCharacter.h"
#include "UObject/ConstructorHelpers.h"

AFALL_GUYS_RESEAUGameMode::AFALL_GUYS_RESEAUGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
