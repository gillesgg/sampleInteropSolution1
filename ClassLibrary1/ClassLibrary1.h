#pragma once
#include <Windows.h>

using namespace System;
using namespace System::Reflection;
using namespace System::Windows::Controls;


namespace ClassLibrary1
{
	public ref class Class1
	{
	public :
		
	public :
		void test(Button ^button)
		{		
			button->Content = L"Set button from MC++";
		}
	};
}





