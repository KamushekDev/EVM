#pragma once
extern "C"
{
	__declspec(dllexport) void __stdcall FromChar(char input);
	__declspec(dllexport) void __stdcall FromShort(short input);
	__declspec(dllexport) void __stdcall FromInt(int input);
	__declspec(dllexport) void __stdcall FromLong(long long input);
	__declspec(dllexport) void __stdcall FromDouble(double input);
	__declspec(dllexport) void __stdcall FromFloat(float input);

	__declspec(dllexport) long long __stdcall ToLong();
	__declspec(dllexport) long long __stdcall ToShort();
	__declspec(dllexport) long long __stdcall ToInt();

}