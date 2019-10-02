#pragma once

#ifdef TESTLIB_EXPORTS
#define TESTLIB_API __declspec(dllexport)
#else
#define TESTLIB_API __declspec(dllimport)
#endif

#include <iostream>

extern "C" {
	void TESTLIB_API SayHello(); 
	int TESTLIB_API GetInt();
	float TESTLIB_API GetFloat();
}

class TESTLIB_API TestLib {
public:
	TestLib() {};
	~TestLib() {};

};