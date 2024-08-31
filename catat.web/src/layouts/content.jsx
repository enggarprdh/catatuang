import  Stack from '@mui/material/Stack';
import Paper from '@mui/material/Paper';
import * as React from 'react';


const Content = ({children}) => {
    return (
        <>
            <Stack spacing={2} direction="row" sx={{position:'fixed', left:0, right:0, top:50, maxHeight:'85vh'}}>
                <div style={{left:0, right:0,width:'100%', overflowY:'scroll', backgroundColor:'whitesmoke'}}>
                    {children}
                </div>
            </Stack>
            
        </>
    );
};

export default Content;