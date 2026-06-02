// Fill out your copyright notice in the Description page of Project Settings.


#include "TwoActor.h"

// Sets default values
ATwoActor::ATwoActor()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void ATwoActor::BeginPlay()
{
	Super::BeginPlay();
	// 추가된 주석
}

// Called every frame
void ATwoActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

