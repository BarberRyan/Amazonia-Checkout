namespace ValidationMachine
{
    public enum VM_Status
    {
        //Validation passes
        OK,

        //Text does not contain only letters
        Not_Alpha,
        
        //Text does not contain only numbers
        Not_Num,
        
        //Text is not strictly alphanumeric
        Not_Alpha_Num,

        //Text does not contain a capital letter
        No_Capital,

        //Text is not equal to specified string (or bad args)
        Not_Equal,
        Bad_Equal_Args,

        //Text is not equal to Text of specified control (or bad args)
        Not_Equal_Control,
        Bad_Equal_Control_Args,

        //Text does not contain the specified string (or bad args)
        Not_Contains,
        Bad_Contains_Args,
        
        //Text does not contain a special character
        No_Spec_Char,

        //Text is below minimum specified length (or bad args)
        Too_Short,
        Bad_Min_Args,

        //Text is above maximum specified length (or bad args)
        Too_Long,
        Bad_Max_Args,

        //Text contains character(s) specified as invalid (or bad args)
        Invalid_Char,
        Bad_Char_Args,

        //Text does not match specified regular expression (or bad args)
        RegEx_Fail,
        Bad_RegEx_Args,

        //Specified function returns false (or bad args)
        Func_Fail,
        Bad_Func_Args
    }
}
