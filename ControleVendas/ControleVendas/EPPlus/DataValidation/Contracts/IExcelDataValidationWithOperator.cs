namespace OfficeOpenXml.DataValidation.Contracts
{
    /// <summary>
    /// Represents a validation with an operator
    /// </summary>
    public interface IExcelDataValidationWithOperator
    {
        /// <summary>
        /// Operator type
        /// </summary>
        ExcelDataValidationOperator Operator { get; set; }
    }
}
