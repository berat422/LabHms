import { Dialog, DialogContent, DialogTitle, makeStyles, withStyles } from '@material-ui/core';
import React from 'react'
import { Button, Input, ItemGroup } from 'semantic-ui-react';
import { useStoreBarnat, useStorePacientat, useStorePaisjet } from '../../app/stores/store';
import CloseIcon from '@material-ui/icons/Close';

const useStyles=makeStyles(theme=>({
    dialogWrapper: {
        padding:theme.spacing(2),
        position:"absolute",
        top:theme.spacing(5)
    }

    
}))
export default function PopUp(props:any) {
const {title,children,openPopup,setopenPopup}=props;
const {PacientatStore}=useStorePacientat();
const{selectedPacienti,closeDetails,closeForm}=PacientatStore
const {PaisjetStore}=useStorePaisjet();
const{paisjet,openForm,selectPaisja,deletePaisja,selectedPaisja,editmode}=PaisjetStore;
const {BarnatStore}=useStoreBarnat();
const{}=BarnatStore;
 const classes=useStyles()

 function close(){
     closeDetails();
    closeForm();
    PaisjetStore.closeForm();
    BarnatStore.closeForm();
    BarnatStore.closeDetails();
 }
    return (
        <Dialog open={openPopup}
        
        fullWidth>
            
            <DialogTitle>
                <ItemGroup>
             <div >{title}</div>
             <Button  onClick={()=>close()}floated="right" content={<CloseIcon/>} color="red"/>
             </ItemGroup>
            </DialogTitle>
            <DialogContent>
                {children}
            </DialogContent>

        </Dialog>


    )
}
