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
	CppProject cppp ("testproject", CppVersion::cpp14);
	int i =0;
	
	ostream* o = &cout;
	istream* mycin = &cin;
	ofstream myfile ("output.txt");
	ifstream myfilein("input.txt");
	o = &myfile;
	//(*mycin) >> i;
	(*o) <<  i << endl;
	if (myfilein.is_open())
	{
		mycin = &myfilein;
		(*mycin) >> i;
		myfilein.close();
	}
	if (myfile.is_open())
	{
		myfile << "This is a line.\n";
		myfile << "This is another line.\n";
		(*o) << "Test" << endl;
		(*o) << i << endl;
		myfile.close();
	}
  else cout << "Unable to open file";
	cout << STDIN_FILENO << endl;
	cout << STDOUT_FILENO << endl;

	cout << "End of programm " << endl;
}
