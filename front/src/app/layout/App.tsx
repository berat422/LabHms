import React, { Fragment, useEffect, useState } from 'react';
import './styles.css';
import Navbar from '../../Components/Navbar';
<<<<<<< HEAD
import { BrowserRouter as Router, Switch, Route, RouteComponentProps,withRouter, useLocation } from 'react-router-dom';
=======
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
<<<<<<< Updated upstream
>>>>>>> parent of ed8d6bc (Krijimi laboratorit front & back end)
import { Container } from 'semantic-ui-react';
import '../../app/layout/styles.css';
import DoktoriDashboard  from '../../Features/Doktori/DoktoriDashbord';
import { observer } from 'mobx-react-lite';
import DepartmentDashboard from '../../Features/Departmentet/Dashboard/DepartmentDashboard';
import HomePage from '../../Features/home/HomePage';
<<<<<<< HEAD
import { ILaboratori } from '../models/ILaboratori';
import axios from 'axios';
import TestErrors from '../../Features/errors/TestError';
import { Slide, ToastContainer } from 'react-toastify';
import NotFound from '../../Features/errors/NotFound';
import ServerError from '../../Features/errors/ServerError';
import PacientiDashboard from '../../Features/Pacineti/PacinetiDashboard'
import FaturaDashboard from '../../Features/Faturat/Dashboard/FaturaDashboard';
import TerminetDashboard from '../../Features/Terminet/TerminetDashboard';
import TerminetList from '../../Features/Terminet/TerminetList';
import ShtratDashboard from '../../Features/Shtreter/Dashboard/ShtratDashboard';
import LlojiShtratitDashboard from '../../Features/llojiShtratit/Dashboard/LlojiShtratitDashboard';
import CaktoShtratinDashboard from '../../Features/caktoShtratin/Dashboard/CaktoShtratinDashboard';
import PaisjetDashbord from '../../Features/Paisjet/PaisjetDashbord';
import InfermierjaDashboard from '../../Features/Infermieret/Dashboard/InfermierjaDashboard';
import LoadingComponent from './LoadingComponent';
import { useStore } from '../stores/store';
import DhomaDashboard from '../../Features/Dhomat/Dashboard/DhomaDashboard';
import LoginForm from '../../Features/users/LoginForm';
import BarnatDashboard from '../../Features/Barnat/BarnatDashboard';
import { Home}  from '../../Features/home/Home';
import ModalContainer from '../common/modals/ModalContainer';
import TherapyDashbord from '../../Features/Therapies/TherapyDashbord';
import RaportForm from '../../Features/Raportet/RaportForm';
import RaportList from '../../Features/Raportet/RaportList';
import RaportDashboard from '../../Features/Raportet/RaportDashboard';
import LaboratoriList from '../../Features/Laboratoret/LaboratoriList';
import LaboratoriForm from '../../Features/Laboratoret/LaboratoriForm';



// const[blooddonors, setBloodDonors]=useState([]);

// greta

const App = () => {

  const[laboratoret, setLaboratoret]=useState<ILaboratori[]>([]);
  const [selectedLaboratori, setSelectedLaboratori]= useState<ILaboratori|null>(
    null);
  const [editMode, setEditMode]=useState(false);

  const handleSelectLaboratori= (id: string) => {
   
    setEditMode(false);

  };
  
  const handleOpenCreateForm=() => {
    setSelectedLaboratori(null);
    setEditMode(true);
  }

  
  // useEffect(() => {
  //   axios
  //   .get<ILaboratori[]>('http://localhost:5000/api/laboratoret')
  //   .then(response=>{
  //     let laboratoret: ILaboratori[]=[];
  //     response.data.forEach(laboratori => {
  //       laboratori.date=laboratori.date.split('.')[0];
  //       laboratoret.push(laboratori);
  //     })
  //     setLaboratoret(laboratoret);
  //     });
  // }, []);
 

  const location=useLocation();
  const {commonStore, userStore} = useStore();

  useEffect(() => {
    if(commonStore.token){
      userStore.getUser().finally(() => commonStore.setAppLoaded());
    }else{
      commonStore.setAppLoaded();
    }
  }, [commonStore, userStore])

  if (!commonStore.appLoaded) return <LoadingComponent content='Loading app...' />

return (
  <Fragment>
  <ToastContainer position='bottom-right' />
  <ModalContainer />
  <Route exact path='/' component={HomePage} />
  <Route
    path={'/(.+)'}
    render={() => (
      <Fragment>
   
      <ToastContainer position='bottom-right' hideProgressBar />
      
      <Navbar  openCreateForm={handleOpenCreateForm}/>
        
        <Switch>
        <Container width={"100vw"} >
        {/* <LaboratoriDashboard laboratoret={laboratoret}
          selectLaboratori={handleSelectLaboratori}
          selectedLaboratori={selectedLaboratori}
          editMode={editMode}
          setEditMode={setEditMode}
          setSelectedLaboratori={setSelectedLaboratori}
          createLaboratori={handleCreateLaboratori}
          editLaboratori={handleEditLaboratori}
          deleteLaboratori={handleDeleteLaboratori} /> */}
          <Switch>
            <Route path='/home' component={Home}/>
=======
=======
import axios from 'axios';
>>>>>>> Stashed changes

function App() {

/*const [infermieret, setInfermieret] = useState([]);
useEffect(() =>{
  axios.get('http://localhost:5000/api/infermieret').then(response =>{
    console.log(response);
    setInfermieret(response.data);
  })
}, [])
 return (
    < div>
    <header as ='h2' icon ='users' content='Infermieret'/>
    <List>
        {infermieret.map((infermierja: any) =>{
          <List.item key=(infermierja.id)</li>
          {infermierja.emri}
          </List.item>
        })}
    </List>
    </div>
*/
  return (
<<<<<<< Updated upstream
   <>
      <Router>
        <Navbar/>
=======
    <>
     <Router>
        <Navbar />
>>>>>>> Stashed changes
        <Switch>
        <Container style={{marginTop: '4em'}}>
          <Route exact path='/' component={HomePage}/>
>>>>>>> parent of ed8d6bc (Krijimi laboratorit front & back end)
          <Route path='/Departamentet' component={DepartmentDashboard}/>
          <Route path='/Infermieret' component={InfermierjaDashboard}/>
          <Route path={'/Doktorat'} component={DoktoriDashboard}/>
          <Route path={'/Pacientat'} component={PacientiDashboard}/>
          <Route path={'/Faturat'} component={FaturaDashboard}/>
 
          <Route path={'/Shtreter'} component={ShtratDashboard} />
          <Route path={'/Paisjet'} component={PaisjetDashbord}/>
          <Route path={'/llojiShtratit'} component={LlojiShtratitDashboard} />
          <Route path={'/caktoShtreterit'} component={CaktoShtratinDashboard} />
          <Route path={'/Dhomat'} component={DhomaDashboard} />
          <Route path='/errors' component={TestErrors} /> 
          <Route exact path={'/Terminet'} component={TerminetDashboard}/>
          <Route  path='/Terminet/:id' component={TerminetList}/>
          <Route path='/server-error' component={ServerError} />
          <Route path='/login' component={LoginForm} />
          <Route path="/Barnat"component={BarnatDashboard}/>
          <Route path="/Therapy"component={TherapyDashbord}/>
          <Route path="/Laboratori"component={LaboratoriForm}/>
          <Route path="/Raport"component={RaportDashboard}/>
          <Route component={NotFound}/>
          </Switch>
        </Container>
        </Switch>
        </Fragment>
        )}
      />
    </Fragment>
  );
<<<<<<< HEAD
};

export default observer (App);
=======
}

export default observer (App);
>>>>>>> parent of ed8d6bc (Krijimi laboratorit front & back end)
