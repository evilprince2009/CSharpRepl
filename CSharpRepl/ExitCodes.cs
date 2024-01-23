namespace CSharpRepl;
internal enum ExitCodes
{
    Success = 0,
    ErrorParseArguments,
    ErrorAnsiEscapeSequencesNotSupported,
    ErrorInvalidConsoleHandle,
    ErrorCancelled
}
    