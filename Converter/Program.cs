#include <iostream>
#include <fstream>
#include <string>
#include <algorithm> 

using namespace std;

int main(int argc, char* argv[])
{
    std::string line, fPth;
    cout << "--Форматирование шейдеров--\n\n";

    if (argc <= 1)
    {
        cout << "--Выполняется без файлов--\n";
        system("Пауза");
        return 0;
    }
    else
    {
        for (int i(1); i < argc; ++i)
        {
            fPth = argv[i];
            ifstream inFile(fPth);
            if (inFile.is_open())
            {
                ofstream outFile("В линии" + to_string(i) + ".txt");
        if (outFile)
        {
            while (getline(inFile, line))
            {
                if (!line.empty())
                {
                    line.erase(std::remove_if(line.begin(), line.end(), [](char c) { return (c == '\r' || c == '\t' || c == ' ' || c == '\n'); }), line.end());
                    if (line != "")
                        outFile << "\"" << line << "\"\n";
                }
            }
            cout << "--Всё гтово! Проверьте \"в линии--" + to_string(i) + ".txt\".--\n";
        }
        else cout << "--Не удается записать в файл--\n";
        outFile.close();
    }

            else cout << "--Не удается открыть файл--\n";
    inFile.close();
}
	}
	system("Пауза");
return 0;
}