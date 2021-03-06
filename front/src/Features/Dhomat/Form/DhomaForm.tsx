import { Formik, Form, Field, ErrorMessage } from 'formik';
import { observer } from 'mobx-react-lite';
import React, { ChangeEvent, useEffect, useState } from 'react';
import { Button, FormField, Header, Label, Segment } from 'semantic-ui-react';
import { useStore } from '../../../app/stores/store';
import * as Yup from 'yup';
import MyTextInput from '../../../app/common/form/MyTextInput';
import MyTextArea from '../../../app/common/form/MyTextArea';
import { IDhoma } from '../../../app/models/IDhoma';
import { llojiDhomesOptions } from '../../../app/FormElements/llojiDhomesOptions';
import MySelectInput from '../../../app/common/form/MySelectInput';
import "../Dashboard/dhoma.css";

export default observer(function DhomaForm() {
    const { dhomaStore } = useStore();
    const { selectedDhoma, closeForm, createDhoma, updateDhoma, loading } = dhomaStore;


    const initialState = selectedDhoma ?? {
        dhoma_Id: '',
        nrDhomes: null,
        pershkrimi: '',
        llojiDhomes: ''
    }

    const [Dhoma, setDhoma] = useState(initialState);
    const validationSchema = Yup.object({
        pershkrimi: Yup.string().required('Pershkrimi dhomes nuk mund te jete i zbrazet...'),
        nrDhomes: Yup.number().required('Numri dhomes nuk mund te jete i zbrazet...').nullable(),
        llojiDhomes: Yup.string().required('Zgjedh llojin e dhomes').nullable()
    })

    function handleFormSubmit(Dhoma: IDhoma) {
        Dhoma.dhoma_Id ? updateDhoma(Dhoma) : createDhoma(Dhoma);
    }

    return (
        <Segment className="ssss" clearing>
            <Formik
                validationSchema={validationSchema}
                enableReinitialize
                initialValues={Dhoma}
                onSubmit={values => handleFormSubmit(values)}>
                {({ handleSubmit, isValid, isSubmitting, dirty }) => (
                    <Form className='ui form' onSubmit={handleSubmit} autoComplete='off'>
                        <label>Numri dhomes: </label>
                        <MyTextInput type='number' name='nrDhomes' placeholder='Shkruani numrin e dhomes...' />
                        <label>Pershkrimi: </label>
                        <MyTextArea rows={3} name='pershkrimi' placeholder='Shkruani pershkrimin e dhomes...' />
                        <label>Lloji dhomes: </label>
                        <MySelectInput options={llojiDhomesOptions} placeholder='Lloji Dhomes' name='llojiDhomes' />
                        <Button 
                        disabled={isSubmitting || !dirty || !isValid}
                        loading={loading} 
                        floated='right' positive type='submit' content='Shto' />
                        <Button onClick={closeForm} floated='right' type='button' content='Anulo' />   
                    </Form>
                )}
            </Formik>

        </Segment>
    )
})