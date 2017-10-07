// ֳכאגםûי DLL-פאיכ.

#include "stdafx.h"
#include "dll1.h"



union Lol {
	char c;
	short s;
	int i;
	long long l;
	double d;
	float f;
};

Lol lol;

__declspec(dllexport)
void __stdcall FromChar(char input) { lol.c=input; }
__declspec(dllexport) 
void __stdcall FromShort(short input) { lol.s=input; }
__declspec(dllexport) 
void __stdcall FromInt(int input) { lol.i=input; }
__declspec(dllexport) 
void __stdcall FromLong(long long input) { lol.l=input; }
__declspec(dllexport) 
void __stdcall FromDouble(double input) { lol.d=input; }
__declspec(dllexport) 
void __stdcall FromFloat(float input) { lol.f=input; }

__declspec(dllexport)
long long __stdcall ToLong() { return lol.l; }
__declspec(dllexport)
long long __stdcall ToInt() { return lol.i; }
__declspec(dllexport)
long long __stdcall ToShort() { return lol.s; }