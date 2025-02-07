#include <Windows.h>
#include "pch.h"
#include <TlHelp32.h>
#include <stdio.h>
#include <tchar.h> // _tcscmp
#include <stdlib.h>


DWORD GetModuleBaseAddress(TCHAR* lpszModuleName, DWORD pID) {
    DWORD dwModuleBaseAddress = 0;
    HANDLE hSnapshot = CreateToolhelp32Snapshot(TH32CS_SNAPMODULE, pID); 
    MODULEENTRY32 ModuleEntry32;
    memset(&ModuleEntry32, 0, sizeof(MODULEENTRY32));
    ModuleEntry32.dwSize = sizeof(MODULEENTRY32);

    if (Module32First(hSnapshot, &ModuleEntry32)) { 
        do {
            if (_tcscmp(ModuleEntry32.szModule, lpszModuleName) == 0) { 
                dwModuleBaseAddress = (DWORD)ModuleEntry32.modBaseAddr;
                break;
            }
        } while (Module32Next(hSnapshot, &ModuleEntry32)); 
    }
    CloseHandle(hSnapshot);
    return dwModuleBaseAddress;
}


// Exported function with parameters
__declspec(dllexport) int Add(int a, int b) {
    return a + b;
}


// Retrieve target address
__declspec(dllexport) DWORD GetTargetAdress(DWORD baseAddress, DWORD offsets[], HANDLE processHandle, int size) {
    DWORD address = baseAddress;
    for (int i = 0; i < size - 1; i++) {
        ReadProcessMemory(processHandle, (LPVOID)(address + offsets[i]), &address, sizeof(address), NULL);
    }
    address += offsets[size - 1];
    return address;
}



// Add Food by Amount
__declspec(dllexport) void AddFood(HANDLE TargetProcess, DWORD baseAddress, DWORD offsets[], float Amount) {
	DWORD address = GetTargetAdress(baseAddress, offsets, TargetProcess, sizeof(offsets) / sizeof(offsets[0]));
	float currentFood;

    ReadProcessMemory(TargetProcess, (LPVOID)(address), &currentFood, sizeof(currentFood), NULL);
	float AddAmount = Amount;
	float newFood = currentFood + AddAmount;
	WriteProcessMemory(TargetProcess, (LPVOID)address, &newFood, sizeof(newFood), 0);
}


// Add Wood by Amount
__declspec(dllexport) void AddWood(HANDLE TargetProcess, DWORD baseAddress, DWORD offsets[], float Amount) {
    DWORD address = GetTargetAdress(baseAddress, offsets, TargetProcess, sizeof(offsets) / sizeof(offsets[0]));
    float currentWood;

    ReadProcessMemory(TargetProcess, (LPVOID)(address), &currentWood, sizeof(currentWood), NULL);
    float AddAmount = Amount;
    float newWood = currentWood + AddAmount;
    WriteProcessMemory(TargetProcess, (LPVOID)address, &newWood, sizeof(newWood), 0);
}


// Add Gold by Amount
__declspec(dllexport) void AddGold(HANDLE TargetProcess, DWORD baseAddress, DWORD offsets[], float Amount) {
	DWORD address = GetTargetAdress(baseAddress, offsets, TargetProcess, sizeof(offsets) / sizeof(offsets[0]));
	float currentGold;

    ReadProcessMemory(TargetProcess, (LPVOID)(address), &currentGold, sizeof(currentGold), NULL);
	float AddAmount = Amount;
	float newGold = currentGold + AddAmount;
	WriteProcessMemory(TargetProcess, (LPVOID)address, &newGold, sizeof(newGold), 0);
}


// Add Stone by Amount
__declspec(dllexport) void AddStone(HANDLE TargetProcess, DWORD baseAddress, DWORD offsets[], float Amount) {
	DWORD address = GetTargetAdress(baseAddress, offsets, TargetProcess, sizeof(offsets) / sizeof(offsets[0]));
	float currentStone;

    ReadProcessMemory(TargetProcess, (LPVOID)(address), &currentStone, sizeof(currentStone), NULL);
	float AddAmount = Amount;
	float newStone = currentStone + AddAmount;
	WriteProcessMemory(TargetProcess, (LPVOID)address, &newStone, sizeof(newStone), 0);
}


// Add all resources by Amount
__declspec(dllexport) void AddAllResources(HANDLE TargetProcess, DWORD baseAddress, DWORD offsets[], float Amount) {
	DWORD address = GetTargetAdress(baseAddress, offsets, TargetProcess, sizeof(offsets) / sizeof(offsets[0]));
	float currentFood;
	float currentWood;
	float currentStone;
	float currentGold;
	float AddAmount = Amount;

    ReadProcessMemory(TargetProcess, (LPVOID)(address), &currentFood, sizeof(currentFood), NULL);
    ReadProcessMemory(TargetProcess, (LPVOID)(address), &currentWood, sizeof(currentWood), NULL);
    ReadProcessMemory(TargetProcess, (LPVOID)(address), &currentStone, sizeof(currentStone), NULL);
    ReadProcessMemory(TargetProcess, (LPVOID)(address), &currentGold, sizeof(currentGold), NULL);

	float newFood = currentFood + AddAmount;
	float newWood = currentWood + AddAmount;
	float newStone = currentStone + AddAmount;
	float newGold = currentGold + AddAmount;
	WriteProcessMemory(TargetProcess, (LPVOID)address, &newFood, sizeof(newFood), 0);
	WriteProcessMemory(TargetProcess, (LPVOID)(address + 4), &newWood, sizeof(newWood), 0);
	WriteProcessMemory(TargetProcess, (LPVOID)(address + 8), &newStone, sizeof(newStone), 0);
	WriteProcessMemory(TargetProcess, (LPVOID)(address + 12), &newGold, sizeof(newGold), 0);
}


// Enable Steroids
__declspec(dllexport) void ToogleOnSteroids(HANDLE TargetProcess, DWORD baseAddress, DWORD offsets[]) {
	DWORD address = GetTargetAdress(baseAddress, offsets, TargetProcess, sizeof(offsets) / sizeof(offsets[0]));
	BYTE SteroidsBytes[] = { 0x1 }; // Enable
	WriteProcessMemory(TargetProcess, (LPVOID)address, &SteroidsBytes, sizeof(SteroidsBytes), 0);
}


// Disable Steroids
__declspec(dllexport) void ToogleOffSteroids(HANDLE TargetProcess, DWORD baseAddress, DWORD offsets[]) {
	DWORD address = GetTargetAdress(baseAddress, offsets, TargetProcess, sizeof(offsets) / sizeof(offsets[0]));
	BYTE SteroidsBytes[] = { 0x0 }; // Disable
	WriteProcessMemory(TargetProcess, (LPVOID)address, &SteroidsBytes, sizeof(SteroidsBytes), 0);
}


// Activate Full Population
__declspec(dllexport) void ActivateFullPopulation(HANDLE TargetProcess, DWORD baseAddress, DWORD offsets[]) {
	DWORD address = GetTargetAdress(baseAddress, offsets, TargetProcess, sizeof(offsets) / sizeof(offsets[0]));
	float currentPopulation;
	float newPopulation = 10000;
	WriteProcessMemory(TargetProcess, (LPVOID)address, &newPopulation, sizeof(newPopulation), 0);
}


// Reset population to 0
__declspec(dllexport) void ResetPopulation(HANDLE TargetProcess, DWORD baseAddress, DWORD offsets[]) {
	DWORD address = GetTargetAdress(baseAddress, offsets, TargetProcess, sizeof(offsets) / sizeof(offsets[0]));
	float resetPop = 0;
	WriteProcessMemory(TargetProcess, (LPVOID)address, &resetPop, sizeof(resetPop), 0);
}


// Add resource when buying something
__declspec(dllexport) void ToogleResourceHack(HANDLE TargetProcess, DWORD baseAddress, DWORD offsets[]) {
	DWORD address = GetTargetAdress(baseAddress, offsets, TargetProcess, sizeof(offsets) / sizeof(offsets[0]));
	BYTE faddBytes[] = { 0xD8, 0xC1 }; //fadd
	BYTE OriginalBytes[] = { 0xD8, 0xE1 }; //fsub
	WriteProcessMemory(TargetProcess, (LPVOID)address, faddBytes, sizeof(faddBytes), 0);
}




// Hooking Steps
// 1. Viết Function declspec(naked) cho inline asm 
// 2. Lấy địa chỉ của hàm cần hook
// 3. Thay đổi protection của trang memory để có thể ghi vào nó
// 4. Copy length bytes của hàm cần hook (Cần ít nhất 5 bytes vì 1 lệnh jmp có 5 bytes 1 byte opcode 4 byte địa chỉ)
// 5. Thêm lệnh jmp đến hàm hook
// 6. Thêm lệnh jmp đến hàm gốc
// Skeleton For Hooking 


BOOL InstallHook(void* toHook, void* ourFunct, int len) {
	if (len < 5) {
		return FALSE;
	} // Minimum 5 bytes for a jump instruction


	// Update protection of the memory page to be able to write to it
	DWORD curProtection;
	VirtualProtect(toHook, len, PAGE_EXECUTE_READWRITE, &curProtection);


	// Copy the original bytes
	memset(toHook, 0x90, len); // Fill remaining bytes with NOP

	// Calculate the relative address by subtracting the address of the function to hook from the address of our function
	DWORD relativeAddress = ((DWORD)ourFunct - (DWORD)toHook) - 5; 
	*(BYTE*)toHook = 0xE9; // JMP

	// Write the address to the next 4 bytes
	*(DWORD*)((DWORD)toHook + 1) = relativeAddress; // Relative address from the jmp instruction to our function

	// Restore the original protection
	DWORD temp;
	VirtualProtect(toHook, len, curProtection, &temp);
	return TRUE;
}

/*
0045DF1A | 66:3B41 4C                 | cmp ax,word ptr ds:[ecx+4C]                     |
0045DF1E | 7D 12                      | jge empiresx.45DF32                             |
0045DF20 | 8B49 50                    | mov ecx,dword ptr ds:[ecx+50]                   |
0045DF23 | D94424 08                  | fld dword ptr ss:[esp+8]                        |
0045DF27 | 0FBFC0                     | movsx eax,ax                                    |
0045DF2A | D80481                     | fadd dword ptr ds:[ecx+eax*4]                   |
0045DF2D | 8D0481                     | lea eax,dword ptr ds:[ecx+eax*4]                |
0045DF30 | D918                       | fstp dword ptr ds:[eax]   
*/


DWORD OriginalAddress = 0x0045DF2A;                 // Address of the original function
__declspec(naked) void HookFunc() {
	__asm {
        // Modify the floating-point value being loaded
        mov dword ptr[esp + 8], 100   // Adjust the value at [esp + 8]
        // Execute the original instructions
        fld dword ptr[esp + 8]          // Restore original instruction
        movsx eax, ax                   // Restore original instruction

        // Jump back to the original code
		jmp OriginalAddress		    // Jump back to the original code
	}
}


DWORD OriginalAddress = 0x004F3B66;
__declspec(naked) void HookFunc2() {
    __asm {
        // Modify the floating-point value being loaded
        mov dword ptr[esp + 8], 0
        // Execute the original instructions
        fld dword ptr[esp + 8]

        // Jump back to the original code
        jmp OriginalAddress		        // Jump back to the original code
    }
}


// Thread chính
DWORD WINAPI MainThread(LPVOID param) {
    BOOLEAN toogleMap = 0; 
    BOOLEAN toogleResource = 0; 
	BOOLEAN toogleSteroids = 0; 
	

    while (1) {
        if (GetAsyncKeyState(VK_F2 ) & 0x8000) {
            // Steroids Cheat
            toogleSteroids = !toogleSteroids; // Toggle state at the start of the function

            HWND hGameWindow = FindWindow(NULL, L"Age of Empires Expansion");

            DWORD pID = 0;
            GetWindowThreadProcessId(hGameWindow, &pID);
            HANDLE processHandle = OpenProcess(PROCESS_ALL_ACCESS, FALSE, pID);

            TCHAR gameName[13];
            wcscpy_s(gameName, 13, L"Empiresx.exe");
            DWORD gameBaseAddress = GetModuleBaseAddress(gameName, pID);
            DWORD offsetGameToBaseAddress = 0x003C4B18;
            DWORD Offset[] = { 0x1C, 0x14 , 0x4 , 0x158, 0xDA4 };

            DWORD baseAddress = 0;
            ReadProcessMemory(processHandle, (LPVOID)(gameBaseAddress + offsetGameToBaseAddress), &baseAddress, sizeof(baseAddress), NULL);
            DWORD pointsAddress = baseAddress;
            for (int i = 0; i < sizeof(Offset) / sizeof(Offset[0]) - 1; i++) {
                ReadProcessMemory(processHandle, (LPVOID)(pointsAddress + Offset[i]), &pointsAddress, sizeof(pointsAddress), NULL);
            }
            pointsAddress += Offset[sizeof(Offset) / sizeof(Offset[0]) - 1];

            // Toggle Steroids
            if (toogleSteroids == 1) {
                BYTE SteroidsBytes[] = { 0x1 }; // Enable
                WriteProcessMemory(processHandle, (LPVOID)pointsAddress, &SteroidsBytes, sizeof(SteroidsBytes), 0);
            }
            else {
                BYTE SteroidsBytes[] = { 0x0 }; // Disable
                WriteProcessMemory(processHandle, (LPVOID)pointsAddress, &SteroidsBytes, sizeof(SteroidsBytes), 0);
            }  
		}
        Sleep(100);

        if (GetAsyncKeyState(VK_F6 ) & 0x8000) {
            // +10000 Food, Wood, Gold, Stone 
            HWND hGameWindow = FindWindow(NULL, L"Age of Empires Expansion");

            DWORD pID = 0;
            GetWindowThreadProcessId(hGameWindow, &pID);
            HANDLE processHandle = OpenProcess(PROCESS_ALL_ACCESS, FALSE, pID);

            TCHAR gameName[13];
            wcscpy_s(gameName, 13, L"Empiresx.exe");
            DWORD gameBaseAddress = GetModuleBaseAddress(gameName, pID);


            DWORD offsetGameToBaseAddress = 0x003C4B18;
            DWORD pointsOffsets[] = { 0x3c, 0x100, 0x50, 0x0 };
            DWORD baseAddress = 0;


            ReadProcessMemory(processHandle, (LPVOID)(gameBaseAddress + offsetGameToBaseAddress), &baseAddress, sizeof(baseAddress), NULL);


            DWORD pointsAddress = baseAddress;
            for (int i = 0; i < sizeof(pointsOffsets) / sizeof(pointsOffsets[0]) - 1; i++) {
                ReadProcessMemory(processHandle, (LPVOID)(pointsAddress + pointsOffsets[i]), &pointsAddress, sizeof(pointsAddress), NULL);
            }
            pointsAddress += pointsOffsets[sizeof(pointsOffsets) / sizeof(pointsOffsets[0]) - 1];

            float currentFood;
            float currentWood;
            float currentStone;
            float currentGold;

            ReadProcessMemory(processHandle, (LPVOID)(pointsAddress), &currentFood, sizeof(currentFood), NULL);
            ReadProcessMemory(processHandle, (LPVOID)(pointsAddress), &currentWood, sizeof(currentWood), NULL);
            ReadProcessMemory(processHandle, (LPVOID)(pointsAddress), &currentStone, sizeof(currentStone), NULL);
            ReadProcessMemory(processHandle, (LPVOID)(pointsAddress), &currentGold, sizeof(currentGold), NULL);


            float addResource = 10000;
            

            float newFood = currentFood + addResource;
            float newWood = currentWood + addResource;
            float newStone = currentStone + addResource;
            float newGold = currentGold + addResource;

            WriteProcessMemory(processHandle, (LPVOID)pointsAddress, &newFood, sizeof(newFood), 0);
            WriteProcessMemory(processHandle, (LPVOID)(pointsAddress + 4), &newWood, sizeof(newWood), 0);
            WriteProcessMemory(processHandle, (LPVOID)(pointsAddress + 8), &newStone, sizeof(newStone), 0);
            WriteProcessMemory(processHandle, (LPVOID)(pointsAddress + 12), &newGold, sizeof(newGold), 0);
        }
        Sleep(100);

        if (GetAsyncKeyState(VK_F7 ) & 0x8000) {
            // Có ngay max population = 200 
            HWND hGameWindow = FindWindow(NULL, L"Age of Empires Expansion");

            DWORD pID = 0;
            GetWindowThreadProcessId(hGameWindow, &pID);
            HANDLE processHandle = OpenProcess(PROCESS_ALL_ACCESS, FALSE, pID);

            TCHAR gameName[13];
            wcscpy_s(gameName, 13, L"Empiresx.exe");
            DWORD gameBaseAddress = GetModuleBaseAddress(gameName, pID);


            DWORD offsetGameToBaseAddress = 0x003C4B18;
            DWORD pointsOffsets[] = { 0x3c, 0x100, 0x50, 0x0 };
            DWORD baseAddress = 0;

            ReadProcessMemory(processHandle, (LPVOID)(gameBaseAddress + offsetGameToBaseAddress), &baseAddress, sizeof(baseAddress), NULL);


            DWORD pointsAddress = baseAddress;
            for (int i = 0; i < sizeof(pointsOffsets) / sizeof(pointsOffsets[0]) - 1; i++) {
                ReadProcessMemory(processHandle, (LPVOID)(pointsAddress + pointsOffsets[i]), &pointsAddress, sizeof(pointsAddress), NULL);
                //   printf("Debug Info: Value at Offset = 0x%lx\n", pointsAddress);
            }
            pointsAddress += pointsOffsets[sizeof(pointsOffsets) / sizeof(pointsOffsets[0]) - 1];
            
            DWORD populationAddress = pointsAddress + 0x10;
            float currentPopulation;

            ReadProcessMemory(processHandle, (LPVOID)(populationAddress), &currentPopulation, sizeof(currentPopulation), NULL);

            float newPopulation = 10000;
            WriteProcessMemory(processHandle, (LPVOID)(populationAddress), &newPopulation, sizeof(newPopulation), 0);   
        }
        Sleep(100); 

        if (GetAsyncKeyState(VK_F8 ) & 0x8000) {
            // Reset dân số hiện tại về 0 -> Unlimited dân số 
            HWND hGameWindow = FindWindow(NULL, L"Age of Empires Expansion");

            DWORD pID = 0;
            GetWindowThreadProcessId(hGameWindow, &pID);
            HANDLE processHandle = OpenProcess(PROCESS_ALL_ACCESS, FALSE, pID);

            TCHAR gameName[13];
            wcscpy_s(gameName, 13, L"Empiresx.exe");
            DWORD gameBaseAddress = GetModuleBaseAddress(gameName, pID);


            DWORD offsetGameToBaseAddress = 0x003C4B18;
            DWORD pointsOffsets[] = { 0x3c, 0x100, 0x50, 0x0 };
            DWORD baseAddress = 0;

            ReadProcessMemory(processHandle, (LPVOID)(gameBaseAddress + offsetGameToBaseAddress), &baseAddress, sizeof(baseAddress), NULL);


            DWORD pointsAddress = baseAddress;
            for (int i = 0; i < sizeof(pointsOffsets) / sizeof(pointsOffsets[0]) - 1; i++) {
                ReadProcessMemory(processHandle, (LPVOID)(pointsAddress + pointsOffsets[i]), &pointsAddress, sizeof(pointsAddress), NULL);
               
            }
            pointsAddress += pointsOffsets[sizeof(pointsOffsets) / sizeof(pointsOffsets[0]) - 1];
            float currentPopulation;

            ReadProcessMemory(processHandle, (LPVOID)(pointsAddress + 44), &currentPopulation, sizeof(currentPopulation), NULL);

            float resetPop = 0;
            WriteProcessMemory(processHandle, (LPVOID)(pointsAddress + 44), &resetPop, sizeof(resetPop), 0);
        }
        Sleep(100);

        if (GetAsyncKeyState(VK_F9 ) & 0x8000) {
            // Unlimited resource hack (Khi tiêu thụ resource sẽ + thay vì -) Full luôn :D 
            toogleResource = !toogleResource;

            HWND hGameWindow = FindWindow(NULL, L"Age of Empires Expansion");
            DWORD pID = 0;
            GetWindowThreadProcessId(hGameWindow, &pID);
            HANDLE processHandle = OpenProcess(PROCESS_ALL_ACCESS, FALSE, pID); // Lấy handle của process 
			TCHAR gameName[13];                                                 // Tên của game
			wcscpy_s(gameName, 13, L"Empiresx.exe");							// Copy tên game vào biến gameName
			DWORD gameBaseAddress = GetModuleBaseAddress(gameName, pID);		// Lấy địa chỉ base của game
            DWORD offsetGameToBaseAddressResource = 0xF3B66;                    // Empriesx.exe + F3B66 
			DWORD TargetAddressBuyResource = gameBaseAddress + offsetGameToBaseAddressResource;// Địa chỉ của resource mình quan tâm trong game memory 
            BYTE faddBytes[] = { 0xD8, 0xC1 };                                  // opcode của fadd
            BYTE OriginalBytes[] = { 0xD8, 0xE1 };                              // opcode của fsub

			DWORD offsetGameToBaseAddressUpgrade = 0xED50A; // 
            DWORD TargetAddressBuyUpgrade = gameBaseAddress + offsetGameToBaseAddressUpgrade;
			BYTE UpgradeAddBytes[] = { 0xD8, 0x45, 0xFC }; // opcode của phần muốn thay đổi (patching bytes)
			BYTE UpgradeOriginalBytes[] = { 0xD8, 0x65, 0xFC }; // opcode của phần muốn thay đổi (patching bytes)

            if (toogleResource) {
				// WriteProcessMemory : Ghi vào memory của process, 1. Handle của process, 2. Địa chỉ cần ghi, 3. Dữ liệu cần ghi, 4. Kích thước của dữ liệu cần ghi, 5. NULL
				// Handle của 1 process cứ tưởng tượng là cái vé, m phải có vé của process đó mới được vào
                WriteProcessMemory(processHandle, (LPVOID)TargetAddressBuyResource, faddBytes, sizeof(faddBytes), NULL);
                WriteProcessMemory(processHandle, (LPVOID)TargetAddressBuyUpgrade, UpgradeAddBytes, sizeof(UpgradeAddBytes), NULL);
            }
            else {
                
                WriteProcessMemory(processHandle, (LPVOID)TargetAddressBuyResource, OriginalBytes, sizeof(OriginalBytes), NULL);
                WriteProcessMemory(processHandle, (LPVOID)TargetAddressBuyUpgrade, UpgradeOriginalBytes, sizeof(UpgradeOriginalBytes), NULL);
            }
        }
        Sleep(100);

        if (GetAsyncKeyState(VK_F5) & 0x8000) {
            // Hook at: `fld dword ptr ss:[esp+8]` which is `0x0045DF23` and `jmp` back at `0x0045DF2A` `fadd dword ptr ds:[ecx+eax*4]` 
            DWORD HookAddress = 0x0045DF23;           // Address of the function to hook
            int len = 7;                              // Length of the function to hook
            
            InstallHook((void*)HookAddress, HookFunc, len);

            // Develop the toggle hook function 
            BYTE OriginalBytes[7];                    // Store the original bytes here
            memcpy(OriginalBytes, (void*)HookAddress, len);

            // Unhook
            DWORD curProtection;
            VirtualProtect((void*)HookAddress, len, PAGE_EXECUTE_READWRITE, &curProtection);
            memcpy((void*)HookAddress, OriginalBytes, len);
            VirtualProtect((void*)HookAddress, len, curProtection, &curProtection);

        }
        Sleep(100);

        if (GetAsyncKeyState(VK_F11) & 0x8000) {
            // Settings 

        }

    }
    return 0;
}



BOOL APIENTRY DllMain(HMODULE hModule, DWORD ul_reason_for_call, LPVOID lpReserved) {
    switch (ul_reason_for_call) {
    case DLL_PROCESS_ATTACH:
        MessageBoxA(NULL, "DLL Injected!", "Success", MB_OK);
        CreateThread(NULL, 0, MainThread, hModule, 0, NULL);
        break;
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}
