import { error } from 'console';
import React from 'react'
import { FieldRenderProps } from 'react-final-form'
;
import { FormFieldProps, Form, Label } from 'semantic-ui-react';

interface IProps extends  FieldRenderProps<string,HTMLTextAreaElement >,FormFieldProps{}

const TextArea:React.FC<IProps> = ({
    input,
    width,
    rows,
    placeholder,
    meta:{touched,error}
}) => {
    return (
        <Form.Field error={touched && !!error} rows={rows} width={width}>
        <textarea {...input}  placeholder={placeholder}/>
        {touched && error && (<Label basic color='red'>{error}</Label>)}
       </Form.Field>
    );
}
export default TextArea