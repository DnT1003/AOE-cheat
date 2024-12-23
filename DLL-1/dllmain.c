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
__declspec(dllexport) void ToogleOnSteroids(HANDLE TargetProcess, DWORD baseAddress, DWORD offsets[], float Amount) {
	DWORD address = GetTargetAdress(baseAddress, offsets, TargetProcess, sizeof(offsets) / sizeof(offsets[0]));
	BYTE SteroidsBytes[] = { 0x1 }; // Enable
	WriteProcessMemory(TargetProcess, (LPVOID)address, &SteroidsBytes, sizeof(SteroidsBytes), 0);
}


// Disable Steroids
__declspec(dllexport) void ToogleOffSteroids(HANDLE TargetProcess, DWORD baseAddress, DWORD offsets[], float Amount) {
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


// Retrieve target address
DWORD GetTargetAdress(DWORD baseAddress, DWORD offsets[], HANDLE processHandle , int size) {
	DWORD address = baseAddress;
	for (int i = 0; i < size - 1; i++) {
		ReadProcessMemory(processHandle, (LPVOID)(address + offsets[i]), &address, sizeof(address), NULL);
	}
	address += offsets[size - 1];
	return address;
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
            HANDLE processHandle = OpenProcess(PROCESS_ALL_ACCESS, FALSE, pID);
            TCHAR gameName[13];
            wcscpy_s(gameName, 13, L"Empiresx.exe");
            DWORD gameBaseAddress = GetModuleBaseAddress(gameName, pID);
            DWORD offsetGameToBaseAddressResource = 0xF3B66;                    // Empriesx.exe + F3B66 
            DWORD TargetAddressBuyResource = gameBaseAddress + offsetGameToBaseAddressResource;
            BYTE faddBytes[] = { 0xD8, 0xC1 };                          //fadd
            BYTE OriginalBytes[] = { 0xD8, 0xE1 };                      //fsub

            DWORD offsetGameToBaseAddressUpgrade = 0xED50A;
            DWORD TargetAddressBuyUpgrade = gameBaseAddress + offsetGameToBaseAddressUpgrade;
            BYTE UpgradeAddBytes[] = {0xD8, 0x45, 0xFC};
            BYTE UpgradeOriginalBytes[] = { 0xD8, 0x65, 0xFC };

            if (toogleResource) {
                
                WriteProcessMemory(processHandle, (LPVOID)TargetAddressBuyResource, faddBytes, sizeof(faddBytes), NULL);
                WriteProcessMemory(processHandle, (LPVOID)TargetAddressBuyUpgrade, UpgradeAddBytes, sizeof(UpgradeAddBytes), NULL);
            }
            else {
                
                WriteProcessMemory(processHandle, (LPVOID)TargetAddressBuyResource, OriginalBytes, sizeof(OriginalBytes), NULL);
                WriteProcessMemory(processHandle, (LPVOID)TargetAddressBuyUpgrade, UpgradeOriginalBytes, sizeof(UpgradeOriginalBytes), NULL);
            }
        }
        Sleep(100);

        if (GetAsyncKeyState(VK_F10) & 0x8000) {
            // Reveal Map + No Fog
            toogleMap != toogleMap; 
        }
        Sleep(100);

        if (GetAsyncKeyState(VK_F11) & 0x8000) {
            // Xem hết thông tin đối thủ
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
