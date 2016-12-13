.PHONY: clean

test: absurdInt.cs absurdIntTest.cs
	mcs -out:$@ $^

clean:
	$(RM) test

