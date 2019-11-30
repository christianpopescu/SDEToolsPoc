#include <bits/stdc++.h>
#include <io.h>


enum class CppVersion {
	cpp11 = 11,
	cpp14 = 14,
	cpp17 = 17
};

class CppProject {
	public:
	CppProject() = delete;
	CppProject(std::string name, CppVersion version) 
	: project_name {"name"},
	 cppVersion{CppVersion::cpp11}	{}
	
	private:
	std::string project_name;
	CppVersion cppVersion;
};

using namespace std;

int main() {
	FILE* stream;
	int stdout_save{dup(STDOUT_FILENO)};
	CppProject cppp ("testproject", CppVersion::cpp14);
	freopen_s(&stream, "makefile.txt","w", stdout);
	cout << STDIN_FILENO << endl;
	cout << STDOUT_FILENO << endl;
	fclose(stdout);
	stdout =fdopen(STDOUT_FILENO,"w");
	cout << "End of programm " << endl;
}
