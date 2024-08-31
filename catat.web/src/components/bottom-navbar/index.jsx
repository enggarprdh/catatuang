import * as React from 'react';
import BottomNavigation from '@mui/material/BottomNavigation';
import BottomNavigationAction from '@mui/material/BottomNavigationAction';
import FavoriteIcon from '@mui/icons-material/Favorite';
import Home from '@mui/icons-material/Home';
import  Summarize from '@mui/icons-material/Summarize';
import Dns from '@mui/icons-material/Dns';

export default function BottomNavbar() {
  const [value, setValue] = React.useState(0);

  return (
      <BottomNavigation
        showLabels
        value={value}
        onChange={(event, newValue) => {
          setValue(newValue);
        }}
      >
        <BottomNavigationAction label="Home" icon={<Home />} />
        <BottomNavigationAction label="Transaction" icon={<Dns />} />
        <BottomNavigationAction label="Reports" icon={<Summarize />} />
      </BottomNavigation>
    
  );
}
