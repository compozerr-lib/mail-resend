import React from "react";

interface Props {
   name: string;
}

const MailResendComponent = (props: Props) => {
   return (
      <div>
         Hello {props.name}
      </div>
   );
}

export default MailResendComponent;