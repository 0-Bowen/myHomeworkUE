// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

#include "ClassExcercise_3rdGameMode.h"
#include "ClassExcercise_3rdCharacter.h"
#include "UObject/ConstructorHelpers.h"

AClassExcercise_3rdGameMode::AClassExcercise_3rdGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
