namespace StbImageSharpInternal
{
#if !STBSHARP_INTERNAL
	public
#else
	internal
#endif
	enum ColorComponents
	{
		Default,
		Grey,
		GreyAlpha,
		RedGreenBlue,
		RedGreenBlueAlpha
	}
}