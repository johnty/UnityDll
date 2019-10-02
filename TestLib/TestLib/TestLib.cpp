// TestLib.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <iostream>
#include "TestLib.h"


void SayHello()
{
	std::cout << "hello from testlib\n";
}

int GetInt()
{
	return 255;
}

float GetFloat()
{
	return 32.0f;
}