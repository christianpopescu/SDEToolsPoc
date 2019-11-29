run : ProjectCpp
	./ProjectCpp

ProjectCpp : ProjectCpp.o
	g++ -std=c++14 ProjectCpp.o -o ProjectCpp

ProjectCpp.o : ProjectCpp.cc
	g++ -std=c++14 -c ProjectCpp.cc
