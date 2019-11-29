#include <bits/stdc++.h>


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
	CppProject cppp ("testproject", CppVersion::cpp14);
	freopen("makefile.testproject","w", stdout);
	
	cout << "End of programm " << endl;
}
