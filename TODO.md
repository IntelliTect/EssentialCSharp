* Change all files to have consistent line endings - presumably Linux.
* Ensure all files are UTF8
* Document that you can't use the is null operator for a non-nullable type
* Verify that it makes sense for Longitued and Latitude to have X and Y (see Listing10.04.ValueTypesNeverReferenceEqualThemselves.cs for example)
* Note the fact that you can't declare a nullable tuple. i.e. (int Year, int Month, int Day)? date = null;