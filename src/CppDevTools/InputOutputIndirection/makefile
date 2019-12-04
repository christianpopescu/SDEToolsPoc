run : ProjectCpp
	./ProjectCpp

ProjectCpp : ProjectCpp.o
	g++ -std=c++17 ProjectCpp.o -o ProjectCpp

ProjectCpp.o : ProjectCpp.cc
	g++ -std=c++17 -c ProjectCpp.cc
