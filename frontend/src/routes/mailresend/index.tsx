import React from "react"
import { createFileRoute } from '@tanstack/react-router'
import MailResendComponent from '../../mailresend-component'

export const Route = createFileRoute('/mailresend/')({
  component: RouteComponent,
})

function RouteComponent() {
  return (
    <div>
      <MailResendComponent name="World!" />
    </div>
  )
}
