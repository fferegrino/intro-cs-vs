run: compile
	mono MstcForm.exe
compile: MstcForm.exe
	
MstcForm.exe:
	mcs /reference:System.Drawing.dll /reference:System.Windows.Forms.dll MstcForm.cs MstcForm.Designer.cs
clean:
	rm MstcForm.exe
