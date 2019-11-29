run : ProjectCpp
	./ProjectCpp.cc

ProjectCpp : ProjectCpp.o
	g++ -std=c++14 ProjectCpp.o -o ProjectCpp.cc

ProjectCpp.o : ProjectCpp.cc
	g++ -std=c++14 -c ProjectCpp.cc
